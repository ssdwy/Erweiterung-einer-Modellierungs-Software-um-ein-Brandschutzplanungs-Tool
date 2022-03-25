# Erweiterung-einer-Modellierungs-Software-um-ein-Brandschutzplanungs-Tool

## Description
A project assignment in Course IIB required designing the appropriate Winform program for the fire protection needs of the building, while making the appropriate changes 
returnable to the Revit API file.

## function characteristics
Read all the floors as well as rooms in the Revit model, while in the GUI interface if the user modifies the corresponding rooms, information in the floors, such as room 
name, type, etc., these contents will also be modified in the Revit model. Users can add fire extinguishers to the room and layout in the revit model, if the room's fire 
still does not meet the regulations, it will prompt to continue adding fire extinguishers.

## Required Software
Autodesk Revit 2019
Revit 2019 SDK 
Microsoft Visual Studio 2019

## NuGet packages
RevitAPI
RevitAPIUI

## Dependencies
Project: IIB1_UE2_Gruppe12_RevitAddin
Dependent on: IIB1_UE1_Gruppe12_Klassenbibliothek, IIB1_UE1_Gruppe12_GUI
