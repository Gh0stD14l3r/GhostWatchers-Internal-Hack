Ghost Watchers Internal Hack - C# DLL Source [Base]

This is a basic mod menu created in C#. It is a base which you can add your own items to it or modifications. Currently it has the following.

![gw_image1](https://user-images.githubusercontent.com/38970826/183768370-8dd17d68-fed8-4a92-9a43-f58bf8b13b17.PNG)


[ESP Menu]
- Ghost ESP [Box, Label, Bones, Distance, Footprints]
- Player ESP [Box, Label, Bones, Distance]
- Cursed Item [Label]
- House Items [Labels, Distance]

[Ghost Menu]
- Make ghost appear
- Teleport ghost to you
- Random Action
- Make Noise
- (Toggle) Ghost stays ontop of you
- Ghost Information

[Player Menu]
- Give Money & Exp (1000 per click) 
Note: You need to do this in game and leave via truck
- Set Host (Should change host ingame to you, untested)
- Unlock Achievements (All steam achievements for the game)
- Toggle Flying (w to fly)
- Brightlight
Note: This changes the light intensity for the house lights and spotlight
- Player Information

[House Menu]
- Open all doors
- (Toggle) Keep all doors open
- Turn on/off all lights
- (Toggle) Keep lights on or off
- Turn all faucets/taps on or off

Insert Key - Show/Hide Menu 
End Key - Unload DLL File safely

To compile..

    Download & Open Sln file for Visual Studio
    Compile in Debug or Release (Doesn't matter)

To Inject..

    Use a Mono injector (Possibly MonoSharpInjector)
    Select Process and browse to the assembly to inject (GhostWatchers.dll)
    Use the following settings.. -- Namespace: GhostWatchers -- Class name: Loader -- Method name: init
    Press inject

Credit to Unknowncheats Member #HoppersButPC, We had a joint collaboration in making our dll's for this game.
