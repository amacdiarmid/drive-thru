put the music gamecomponent on the start menu (so it doesnt duplicate)
add the music to the corret sections in the music script(the current music is for testing puropses)
put the music caller gameobject in every scene except for the menus put one on the main menu
on every music caller change the music number depending on the level
	(1 = multiplayer
	 2 = sci fi
	 3 = gangster
	 4 = western
	 5 = main menu)


put the SFX game object on the start menu
put the button sound on that gameobject
on all of the onMouseUp functions put this 
		GameObject button = GameObject.Find("SFX");
		buttonpress callbutton = (buttonpress) button.GetComponent(typeof(buttonpress));
		callbutton.button();

note: the character spawner gameobject for multiplayer needs to be on the start menu aswell so it too doesnt duplicate.
the music in this is also for testin so it will need to be replaced with the final music