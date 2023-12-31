**QUICKSTART MODDING GUIDE**

-download visual studio

-clone open source mod repo

-make changes

-make red squiggles go away

-test in game

-repeat until working

**RPGAddOns**

RPGAddOns interfaces with existing RPGMod systems to provide a way for players to reset their level for additional stats and rewards. PvE Rank points from killing VBloods are now working as well.

Example config: https://github.com/mfoltz/BlueBuilds/blob/master/RPGAddOns.cfg

https://github.com/oscarpedrero/BloodyPoints is a great mod to start poking around in if you're new to this.

**Commands**
___________________________________
Command: .rpg resetlevel or .rpg rl

Admin: false

Usage: Use this command to reset your level to 1 after reaching max level to receive configured extras.

Description: This command allows you to reset your level for rewards once you've reached the maximum level.
___________________________________
Command: .rpg getresets or .rpg gr

Admin: false

Usage: Check your current reset count.

Description: Displays the number of times you have reset your level.
___________________________________
Command: .rpg getbuffs or .rpg gb

Admin: false

Usage: Check your current permanent buffs.

Description: Displays the buffs you have received from resets.
___________________________________
Command: .rpg wiperesets or .rpg wr <PlayerName>

Admin: true

Usage: Resets the specified user's reset count and buffs to the initial state.

Description: This command resets a player's resets, including their reset count and buffs. It does not remove the buffs from their player character as that can be done with other commands but will add later
___________________________________
Command: .rpg getresetdata or .rpg grd <PlayerName>

Admin: true

Usage: Retrieves the reset count and buffs for a specified player.

Description: Use this command to view the reset count and buffs of a specific player.
