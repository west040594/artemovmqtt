package com.tstu;

import org.eclipse.paho.client.mqttv3.MqttClient;
import org.eclipse.paho.client.mqttv3.MqttException;

public class App
{
    public static void main( String[] args ) throws MqttException {
        String topicName = "sample";
        if(args.length == 1) {
            topicName = args[0];
        }
        System.out.println("== START SUBSCRIBER ==");
        MqttClient client=new MqttClient("tcp://localhost:1883", MqttClient.generateClientId());
        client.setCallback( new SimpleMqttCallBack() );
        client.connect();
        client.subscribe(topicName);
    }
}
