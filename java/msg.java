package me.masonrapa.plugin;

import java.io.BufferedReader;
import java.io.File;
import java.io.FileReader;
import java.io.IOException;
import java.util.concurrent.TimeUnit;

import org.bukkit.Bukkit;

public class msg implements Runnable {
	public static String text;
	public static String verification1;
	public static String verification2;
	
	public void run() {
		while (""=="") {
			try {
				TimeUnit.SECONDS.sleep(1);
		        BufferedReader br = new BufferedReader(new FileReader("C:\\xampp\\htdocs\\OutNet\\msg.txt"));
		        String text = br.readLine();
		        br.close();
		        File myObj = new File("C:\\xampp\\htdocs\\OutNet\\msg.txt"); 
		        myObj.delete();
		        Bukkit.broadcastMessage("§2[§aOutNet§2] §f>> §6"+text.replace("\r","").replace("[","[§c").replace("]","§6]"));
		        verification2 = text;   
			} catch (IOException e) {
			} catch (NullPointerException e) {
			} catch (InterruptedException e) {
				e.printStackTrace();
			}
		}
	}
}
