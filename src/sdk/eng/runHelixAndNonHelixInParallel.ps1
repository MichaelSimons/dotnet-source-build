    [CmdletBinding(PositionalBinding = $false)]
    Param(
        [string] $configuration,
        [string] $buildSourcesDirectory,
        [string] $customHelixTargetQueue,
        [string] $additionalMSBuildParameters = "",
        [switch] $test
    )

    if (-not $test)
    {
        Write-Output "No '-test' switch. Skip both helix and non helix tests"
        return
    }

    workflow runHelixAndNonHelixInParallel
    {
        Param(
            [string] $configuration,
            [string] $buildSourcesDirectory,
            [string] $customHelixTargetQueue,
            [string] $engfolderPath,
            [string[]] $additionalParameters
        )

        $runTestsCannotRunOnHelixArgs = ("-configuration", $configuration, "-ci")
        $runTestsOnHelixArgs = ("-configuration", $configuration,
        "-prepareMachine",
        "-ci",
        "-restore",
        "-test",
        "-projects", "$buildSourcesDirectory/src/Tests/UnitTests.proj",
        "/bl:$buildSourcesDirectory\artifacts\log\$configuration\TestInHelix.binlog",
        "/p:_CustomHelixTargetQueue=$customHelixTargetQueue") + $additionalParameters

        parallel {
            Write-Output "&'$engfolderPath\runTestsCannotRunOnHelix.ps1' $runTestsCannotRunOnHelixArgs"
            Invoke-Expression "&'$engfolderPath\runTestsCannotRunOnHelix.ps1' $runTestsCannotRunOnHelixArgs"
            Write-Output "&'$engfolderPath\common\build.ps1' $runTestsOnHelixArgs"
            Invoke-Expression "&'$engfolderPath\common\build.ps1' $runTestsOnHelixArgs"
        }
    }

    runHelixAndNonHelixInParallel -configuration $configuration -buildSourcesDirectory $buildSourcesDirectory -customHelixTargetQueue $customHelixTargetQueue -engfolderPath $PSScriptRoot -additionalParameters $additionalMSBuildParameters.Split(' ') 
