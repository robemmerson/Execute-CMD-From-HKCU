# Execute-CMD-From-HKCU
Executes whatever commands are stored in HKCU\Software\Microsoft\exe as a silent CMD window

### Purpose
I created this application for running batch commands silently with the Bash Bunny from Hak5 in mind (https://hakshop.com/products/bash-bunny). Batch files packaged in an 'iexpress' wrapper do not execute when being launched from 'HKCU\Software\Microsoft\Windows\App Paths\control.exe' (existing UAC bypass when running 'sdclt'). This app allows me to insert the command I need to run into the registry and then execute it silently while bypassing UAC completely.

### Props
Hak5 for constantly innovating with new and impressive hardware! Go support them: https://hakshop.com
