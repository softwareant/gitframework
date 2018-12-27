# gitframework
GIT Load Tool Framework

This framework is a tool which is a frontend which will build the scripts required to configure up a GIT MIgration Toolset.

The idea behind this is to quickly build a standaradised GIT toolset which will:
a. Provide validation scripts to validate the source data before load to pick up common load issues such as:
- Parent Missing
- Name field being longer than  255 chans
- Identify verisons that have multiple parents
- Identify files that are greater than 1 GB in size
- Identify duplicate records
- Identify file not found for document loads
- Identify duplicate barcodes for physical records
- Identify duplicate physical file numbers

b. It will also generate templated sql, scripts and GIT xml configuration which will
This includes:
- Templates for the transform scripts
- Templates for the xml config used to load a type of object
- Templates for the run scripts (including number of threads etc

It works on the principal of ETL (Extract/Transform/Load) and focuses on standardizing the "load" part of the process.

You will still have to write sql to get the extract into the standard format.

This tool spearates the system metadata in the standard source from the metadata

The main part of the 

It iwll also generate the load statistics to help produce the report and help identify the exceptions.

The frontend will generate and execute powershell scripts/sql/configuration, and then execute them

The framework application will have have the follwoing structure:
GITFramework\<version>\bin\GITFrameworkFrontend.exe
GITFramework\<version>\bin\GITFrameworkFrontend.exe.config
GITFramework\<version>\resources\bin
GITFramework\<version>\templates
GITFramework\<version>\templates\gitxml
GITFramework\<version>\templates\scripts
GITFramework\<version>\templates\sql
GITFramework\<version>\projects\<projectname>.config


When you create a new project it will save the core project config in the GITFramework\<version>\projects directory.
The project will contain the following structure:

<project top level dir>
<project top level dir>\bin
<project top level dir>\config
<project top level dir>\extract
<project top level dir>\extract\scripts
<project top level dir>\extract\sql
<project top level dir>\transform
<project top level dir>\transform\scripts
<project top level dir>\transform\sql
<project top level dir>\load
<project top level dir>\load\scripts
<project top level dir>\load\sql
<project top level dir>\load\gitxml
<project top level dir>\load\run
<project top level dir>\load\run\DATETIMESTAMP_TYPEOFLOAD__DESCRIPTION_MODE_THREADNO
<project top level dir>\load\run\DATETIMESTAMP_TYPEOFLOAD__DESCRIPTION_MODE_THREADNO\config.xml
<project top level dir>\load\run\DATETIMESTAMP_TYPEOFLOAD_MODE_<THREADNO>\messages.txt
<project top level dir>\load\run\DATETIMESTAMP_TYPEOFLOAD_MODE_<THREADNO>\exceptions.txt
  


