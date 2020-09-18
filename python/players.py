from ping.scripts import mcstatus
from sys import argv
MinecraftServer = mcstatus.MinecraftServer
jugatori = MinecraftServer.lookup(argv[2]).status()
if argv[1] == "A":
	print (str(jugatori.players.online)+"/"+str(jugatori.players.max))
if argv[1] == "B":
	pl = []
	for player in jugatori.players.sample:
		pl.append(player.name)
	pl = str(pl).replace("['","").replace("']","").replace("', '",",")
	print (pl)
