# CopyTransform Tool
[![License](https://img.shields.io/badge/License-MIT-green.svg)](https://github.com/JAFS6/CopyTransformTool/blob/develop/LICENSE.txt)
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

<img src="https://cloud.githubusercontent.com/assets/6010819/18322785/c67bb7b0-7534-11e6-9d3c-f796b7f6c0a5.jpg" alt="CopyTransformTool Window image" height="300px">

**Select/Unselect** the elements to copy, checking/unchecking the checkboxes for **Position**, **Rotation**, **Scale** and **Parent**.

**Select** the source Transform on the **Source Transform** slot.

**Select** the target **GameObject(s)** on the scene, clicking them on the hierarchy or in the scene view. Shift click to add multiple GameObjects.

<img src="https://cloud.githubusercontent.com/assets/6010819/18322797/d4f08f6e-7534-11e6-887a-cc182da0108a.jpg" alt="CopyTransformTool Window items selected image" height="300px">

**Click** on the **copy elements** button.

You can **Undo** the changes with **CTRL + Z** or **Edit > Undo Copy Transform elements**.

# Troubleshooting
If you have any problem, question, suggestion or bug report, [open an issue](https://github.com/JAFS6/CopyTransformTool/issues/new) and we will try to solve it.

# Contributing
If you want to help improve this tool, please test it and [create a new issue](https://github.com/JAFS6/CopyTransformTool/issues/new) if you find any bug.

# License
This tool is licensed under the [MIT license](https://opensource.org/licenses/MIT).

# Author
[Juan Antonio Fajardo Serrano](https://es.linkedin.com/in/jafs6)
