# BrainPad_TinyCLR_V1
### Run TinyCLR V1 on GHI BrainPad BP2

### Installation of the GHI Bootloader and of the firmware with Teraterm:
#### Install the GHI Bootloader
1) Hold 'Boot0' Button and press the 'Reset' Button
    In Windows Device Manager under USB-Controller an entry 'STM Device in DFU Mode' shows up
2) Install and open the Programm 'DfuSeDemo' from ST-Microelectronics.
    In the Available DFU Devices-ComboBox you see: 'STM Device in DFU Mode'
3) Click the 'Choose' button and navigate to and open the file: 'FEZCLR Bootloader v2.0.4.dfu'
4) Click 'Upgrade', when finished --> Quit and repower the board

#### Install the Firmware
1) Hold Left (L) Button and press 'Reset'
    Now in Windows Device Manager under (COM && LPT) 'GHI Bootloader Interface (COM..) shows up
3)  Open Teraterm and under 'Serial' connect to the just created COM Port.
    You can enter commands:
         v(CR) shows the version
         e(CR) erases the board firmware
         u(CR) is used to load a new firmware to the board
4) erase the firmware with e(CR)
5) use command u(CR) 
          then, when continuing 'C' are appearing on the screen: --> File --> Transfer --> XModem --> Send –> Set Option ‘1K’ --> select ‘FEZCLR Firmware v1.0.0.glb’
          (important: don't forget to activate the '1K' Checkbox)
          
Now prepare Visual Studio:
1) Under 'Tools' --> 'Extensions and Updates' Deinstall evtl. installed newer Versions of TinyCLR Project System
2) Download the file TinyCLROSProjectSystemv1.0.0.vsix





    

