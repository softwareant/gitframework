.\00_Config.ps1

$numGITInstances = REPLACEME_NO_OF_GIT_INSTANCES
$counter = 0
$typeOfLoadAbbrev = 'REPLACEME_TYPE_OF_LOAD_ABBREV_REPLACEME'
$typeOfLoadDescritpion = 'REPLACEME_TYPE_OF_LOAD_DESC_REPLACEME'
if ($numGITInstances -gt 0)
{
    $counter = 0
    while ($counter -lt $numGITInstances)
    {
        # Create A New Run Directory
        $counterStr = $counter.ToString('00')
        $runPath = "$PROJECT_RUN_PATH\$TIMESTAMP"
        $currThreadPath = "$runPath_$typeOfLoadAbbrev_$typeOfLoadDescritpion_$MODE_T-$counterStr"
        mkdir $currThreadPath

        # Copy Templated GIT Config Files To Directory

        # Copy Templated Script Files To Directory

        # Replace RELACEME Variables in Config Files
        
        # Replace RELACEME Variables in Script Files
                
        $counter = $counter + 1
    }

    #Launch Script Files
    $counter = 0
    while ($counter -lt $numGITInstances)
    {
        
    }
}