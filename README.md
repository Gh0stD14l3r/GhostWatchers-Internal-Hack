Ghost Watchers Internal Hack - C# DLL Source [Base]

Download pre-compiled DLL from here https://www.unknowncheats.me/forum/other-fps-games/510145-ghost-watchers-internal-esp-fly.html

This is a basic mod menu created in C#. It is a base which you can add your own items to it or modifications. Currently it has the following.

![image](https://user-images.githubusercontent.com/38970826/191117533-046deaf2-c788-4f4e-af7e-e1e4a9db8edb.png)

[ESP Menu]

    Ghost ESP [Box, Label, Bones, Distance, Footprints]
    Ghost Items ESP [Label]
    Player ESP [Box, Label, Bones, Distance]
    Cursed Item [Label]
    House Items [Labels, Distance]


[Ghost Menu]

    Make ghost appear
    Teleport ghost to you
    Random Action
    Make Noise
    (Toggle) Ghost stays ontop of you
    Ghost Information


[Player Menu]

    Give Money & Exp (1000 per click) Note: You need to do this in game and leave via truck
    Set Host (Should change host ingame to you, untested)
    Unlock Achievements (All steam achievements for the game)
    Toggle Flying (w to fly)
    Brightlight Note: This changes the light intensity for the house lights and spotlight
    Player Information


[House Menu]

    Open all doors
    (Toggle) Keep all doors open
    Turn on/off all lights
    (Toggle) Keep lights on or off
    Turn all faucets/taps on or off
    Turn all candles on or off


[Spawn Menu]

    Spawn ghosts in


Note: Some are not assigned (Twins, Doppelganger, SupremeDemon, etc). More ghosts impacts performance, disable bone esp to speed it up

[Troll Menu]

    Player info (Is protected, Is the target)
    Teleport to player
    Teleport ghost to player
    Pretend attack (starting stage of attack)
    Attack (ghost will give them a jump scare, sometimes will actually kill them)


[Offensive Menu]

    Use offensive tools on the ghost to weaken it


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
