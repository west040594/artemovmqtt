package com.tstu;

import org.eclipse.paho.client.mqttv3.MqttClient;
import org.eclipse.paho.client.mqttv3.MqttException;
import org.eclipse.paho.client.mqttv3.MqttMessage;

public class App 
{
    public static void main( String[] args ) throws MqttException {
        String topicName = "sample";
        String messageString = "10";
        if (args.length == 1) {
            messageString = args[0];
        }
        if (args.length == 2) {
            messageString = args[0];
            topicName = args[1];
        }
        System.out.println("== START PUBLISHER ==");
        MqttClient client = new MqttClient("tcp://localhost:1883", MqttClient.generateClientId());
        client.connect();
        MqttMessage message = new MqttMessage();
        message.setPayload(messageString.getBytes());
        client.publish(topicName, message);
        System.out.println("\tMessage '"+ messageString +"' to " + topicName);
        client.disconnect();
        System.out.println("== END PUBLISHER ==");
    }
}
