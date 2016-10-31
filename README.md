# CopyTransform Tool
[![License](https://img.shields.io/badge/License-MIT-green.svg)](https://github.com/JAFS6/CopyTransformTool/blob/master/LICENSE.txt)
![](https://img.shields.io/badge/Unity3D%20version-5.4.0-lightgrey.svg)

Unity3D editor tool to copy elements of one GameObject's transform to others.

--------

# Motivation
Have you ever placed a GameObject carefully in a place and have you noticed afterward you need another GameObject placed on its place? Maybe you want to match the rotation of one GameObject to place several copies in a row? Whatever your need is, this lightweight tool will help you in that moments, saving development time.

# Setup
**Download** the latest version of **CopyTransform Tool** from the [releases page](https://github.com/JAFS6/CopyTransformTool/releases). You can choose between the zip file or the unity package.

## Setup from zip file
Unzip it and **put** the **CopyTransformTool folder on** your Unity3D **project's assets folder**.

## Setup from unity package
Import the package: **Assets > Import Package > Custom Package**, select the file and **import** all.

## Result
Whatever form you use, you will see a **new entry on the Window menu** called **CopyTransform Tool**.

#Usage
Click the **Window > CopyTransform Tool** to open de tool's window.

<img src="https://cloud.githubusercontent.com/assets/6010819/19863322/18523cec-9f94-11e6-9a53-bb99c953b6cf.jpg" alt="CopyTransformTool Window image" height="300px">

**Select/Unselect** the elements to copy, checking/unchecking the checkboxes for **Position**, **Rotation**, **Scale** and **Parent**.

**Select** the source Transform on the **Source Transform** slot.

**Select** the target **GameObject(s)** on the scene, clicking them on the hierarchy or in the scene view. Shift click to add multiple GameObjects.

<img src="https://cloud.githubusercontent.com/assets/6010819/19863323/1856837e-9f94-11e6-9f03-4bd33052dd46.jpg" alt="CopyTransformTool Window items selected image" height="300px">

**Click** on the **copy elements** button.

You can **Undo** the changes with **CTRL + Z** or **Edit > Undo Copy Transform elements**.

## Additional features

**Reset** position, rotation and/or scale checking/unchecking them, select the desired GameObjects and clicking over the **Reset elements** button.

**Clear** source transform easily clicking the clear button.

# Troubleshooting
If you have any problem, question, suggestion or bug report, [open an issue](https://github.com/JAFS6/CopyTransformTool/issues/new) and we will try to solve it.

# Contributing
If you want to help improve this tool, please test it and [create a new issue](https://github.com/JAFS6/CopyTransformTool/issues/new) if you find any bug.

# License
This tool is licensed under the [MIT license](https://opensource.org/licenses/MIT).

# Author
[Juan Antonio Fajardo Serrano](https://es.linkedin.com/in/jafs6)
