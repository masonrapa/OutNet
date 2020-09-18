package me.masonrapa.plugin;


import java.io.BufferedReader;
import java.io.FileReader;
import java.io.FileWriter;
import java.io.IOException;

import org.bukkit.Bukkit;
import org.bukkit.command.CommandExecutor;
import org.bukkit.event.EventHandler;
import org.bukkit.event.Listener;
import org.bukkit.event.player.AsyncPlayerChatEvent;
import org.bukkit.plugin.java.JavaPlugin;

	
public class Main extends JavaPlugin implements Listener, CommandExecutor{
	
	public static String testo;
	
	public void onEnable() {
		getServer().getPluginManager().registerEvents(this, this);
		Bukkit.getServer().getConsoleSender().sendMessage("§a[§fOutNet§a] §aStarting Plugin!");
        msg thpun = new msg();
        Thread thre = new Thread(thpun);
        thre.start();
	}
	public void onDisable() {
		Bukkit.getServer().getConsoleSender().sendMessage("§a[§fOutNet§a] §7Stopping Plugin!");
	}
	
    @EventHandler
    public void onSpeak(AsyncPlayerChatEvent event) throws IOException {
    	String text = event.getMessage();
    	String name = event.getPlayer().getName();
        BufferedReader br = new BufferedReader(new FileReader("C:\\xampp\\htdocs\\OutNet\\logs.txt"));
        try {
            StringBuilder sb = new StringBuilder();
            String line = br.readLine();
            while (line != null) {
                sb.append(line);
                sb.append(System.lineSeparator());
                line = br.readLine();
            }
            testo = sb.toString();
        } finally {
            br.close();
        }
        FileWriter file = new FileWriter ("C:\\xampp\\htdocs\\OutNet\\logs.txt");
		file.write(testo.replace("\n","")+"["+name+"] > "+text+"^^^^");
		file.close();
    }
	
}
