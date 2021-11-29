[![VRTK logo][VRTK-Image]](#)

# VR Bowling Game Tutorial

> _This has been tested on version 2019.4.28f1 of the Unity software_

[![License][License-Badge]][License]
[![Backlog][Backlog-Badge]][Backlog]
[![Discord][Discord-Badge]][Discord]
[![Videos][Videos-Badge]][Videos]
[![Twitter][Twitter-Badge]][Twitter]

## Introduction

A tutorial on how to make a VR Bowling game using the components from the VRTK suite within the [Unity] software.

This tutorial covers the basics of getting a VR camera working within Unity and being able to interact with objects within the scene.

> If you're using Unity 2020.1 or above then please refer to the [Converting To Unity 2020] tutorial.

![VR Bowling Scene](https://user-images.githubusercontent.com/36199993/74746663-af050780-525d-11ea-8eb0-6ba279fed0f7.gif)

## Getting Started

Follow the [Making A VR Bowling Game] tutorial to build this project yourself in an empty Unity project or follow the instructions below to download the completed project.

### Downloading the project

* Download this project repository to your local machine using *one* of the following methods:
  * Git clone the repository with `git clone https://github.com/ExtendRealityLtd/VRTK.Tutortials.VRBowling.git`
  * Download the zip file at `https://github.com/ExtendRealityLtd/VRTK.Tutortials.VRBowling/archive/master.zip` and extract it.

### Opening the downloaded project in the Unity software

> **Do not** drag and drop this downloaded tutorial project into an existing Unity project. The downloaded tutorial project **is a Unity project** already and you should not nest a Unity project inside another Unity project. Follow the instructions below for opening this tutorial project within the Unity software.

#### Using the Unity Hub

* Open the [Unity Hub] panel.
* Click the `Add` Button.
* Browse to the local directory where the repository was cloned/downloaded to and click `Select Folder`.
* The tutorial project will now show up in the Unity Hub project window, so select `VRTK.Tutortials.VRBowling` to open the project in the Unity software.
* The `VRTK.Tutortials.VRBowling` project will now open within the Unity software.

#### Opening from within the Unity software

* Select `Main Menu -> File -> Open Project` within the Unity software.
* Browse to the local directory where the repository was cloned/downloaded to and click `Select Folder`.
* The `VRTK.Tutortials.VRBowling` project will now open within the Unity software.

### Running the game scene

* Open the `Assets/Scenes/BowlingAlley` scene.
* Enable `Maximize On Play` in the Unity Game view control bar to ensure no performance issues are caused by the Unity Editor overhead.
* Play the scene in the Unity Editor (`CTRL` + `P`).
* The scene should automatically play within any Unity supported XR hardware.

## Contributing

We're not currently in a place where accepting contributions would be helpful. But as soon as we're ready we'll let you know!

## License

Code released under the [MIT License][License].

## Disclaimer

These materials are not sponsored by or affiliated with Unity Technologies or its affiliates. "Unity" is a trademark or registered trademark of Unity Technologies or its affiliates in the U.S. and elsewhere.

[VRTK-Image]: https://raw.githubusercontent.com/ExtendRealityLtd/related-media/main/github/readme/vrtk.png
[Unity]: https://unity3d.com/
[Converting To Unity 2020]: Documentation/Tutorials/ConvertingToUnity2020/README.md
[Making A VR Bowling Game]: Documentation/Tutorials/MakingAVRBowlingGame/README.md

[License-Badge]: https://img.shields.io/github/license/ExtendRealityLtd/VRTK.svg
[Backlog-Badge]: https://img.shields.io/badge/project-backlog-78bdf2.svg

[Discord-Badge]: https://img.shields.io/badge/discord--7289DA.svg?style=social&logo=discord
[Videos-Badge]: https://img.shields.io/badge/youtube--e52d27.svg?style=social&logo=youtube
[Twitter-Badge]: https://img.shields.io/badge/twitter--219eeb.svg?style=social&logo=twitter

[License]: LICENSE.md
[Backlog]: http://tracker.vrtk.io

[Discord]: https://discord.com/invite/bRNS6hr
[Videos]: http://videos.vrtk.io
[Twitter]: https://twitter.com/VR_Toolkit

[Unity Hub]: https://docs.unity3d.com/Manual/GettingStartedUnityHub.html

## Introduction and Description

My project takes my Project 2 scene and recreates it in multiple ways. There is a “Mego Playset” scene that takes the building and makes it a playset that can be played with, a “Land of the Giants” scene that makes the user small and places them on top of a cubicle table, a “Dancing on the Ceiling” scene that makes the whole building rotate clockwise or counter clockwise depending on the button you press, and a “Zero Gravity” scene that has all the interactables have no gravity. All of these scenes are linked together through a menu that is tracked on the left controller so it can be easily accessible to the player.

## Github page

This is the Github page for my project. The version of Unity used was Unity 2019.4.28f1 and the version of VRTK used was VRTK 4. To run the application and the code on an Oculus, download the zip file from the Github page, and unzip it. Open up the project in Unity and plug in the VR headset to the PC. The build settings are set to the right settings except for the run device setting. Select the VR headset in the run device setting and build and run. It will take some time, but once it is done building, the application will be on the device. 

## Assets/ Sources used

All of the assets from Project 2 are still there. These are the new ones used:

### Menu/Labels for the menu:

#### Made by me:



### In “Mego Playset” scene:

Lamp for mego playset: https://sketchfab.com/3d-models/desk-lamp-low-poly-0dded6b36c464294a0ab966b18109f6d

Flashlight for mego playset: https://sketchfab.com/3d-models/flashlight-12d6911e84154d2ab485d983361df76f

Halo Reach character for mego playset (interactable and animated): https://sketchfab.com/3d-models/spartan-armour-mkv-halo-reach-57070b2fd9ff472c8988e76d8c5cbe66

Kirby character for mego playset (interactable and animated): https://sketchfab.com/3d-models/kirby-20-25542bdf23564b1a98d6b46f21b1d624


### In “Land of the Giants” scene:
#### Textures:

Ruler texture: https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.shutterstock.com%2Fsearch%2Fyardstick&psig=AOvVaw38wk8Jkai8fKp6yP1gUWOD&ust=1637904313669000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCMjjjpjjsvQCFQAAAAAdAAAAABAN

Journal texture: https://www.texturex.com/wp-content/uploads/2018/03/brown-leather-texture-pattern-soft-mateial-hand-made-journal-5-500x333.jpg


#### Models:

Ruler was made by me (interactable)

Pen (interactable) : https://free3d.com/3d-model/pen-v2--963162.html

Pencil (interactable) : https://sketchfab.com/3d-models/pencil-9e0dba29de734ac4b20060ec873dc36c

Filing cabinet : https://sketchfab.com/3d-models/office-filing-cabinet-free-cd6f9016db8644129af1b6026f9e46bd

Office chair: https://sketchfab.com/3d-models/office-chair-db03012c3c484314a480b4137da8eb30

Eraser (interactable): https://sketchfab.com/3d-models/low-poly-eraser-eb8e47bc0b92455b9722b45e61e94372

Journal (interactable): https://sketchfab.com/3d-models/journal-oxblood-leather-bound-notebook-660a71e0c4c647748f927613a669a233

Laptop (interactable): https://sketchfab.com/3d-models/lowpoly-laptop-closed-eeef6b210bf448bba80723d0783939a9

Sharpener (interactable): https://sketchfab.com/3d-models/day20-sharpener-520e43463f7c4f4f8be96f8ff9986b0e

Stapler (interactable): https://sketchfab.com/3d-models/stapler-eb02cd20aafd4e21bc1a5f3252e8a914


### In “Dancing on the Ceiling” scene:

#### Textures:

Rotate arrow: https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.kindpng.com%2Fimgv%2FhwRhbbb_svg-circle-arrow-rotate-symbol-png-transparent-png%2F&psig=AOvVaw2FQab1YaN03EG51jGzzL4B&ust=1638070518988000&source=images&cd=vfe&ved=0CAsQjRxqFwoTCKj1ubLOt_QCFQAAAAAdAAAAABAe




## Video Link:


## Discussion:

