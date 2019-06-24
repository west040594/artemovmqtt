document.addEventListener("DOMContentLoaded", function(event) { 
    
});


function sendMessage() {
    message = new Paho.MQTT.Message(document.getElementById("queue_message").value);
    message.destinationName = document.getElementById("queue_topic").value;
    client.send(message);
}

function onMessageArrived(message) { 
    document.getElementById("queue_messages").innerHTML += message.payloadString + '</br>';
} 

function onConnectionLost(responseObject) {
    console.log("connectionLost" + responseObject.errorMessage);
}


function onConnect() {
    topic = document.getElementById("queue_topic").value;
    client.subscribe(topic);
}

function startConnect() {
    clientID = "java_script_clientID_" + parseInt(Math.random() * 100);
    host = document.getElementById("queue_host").value;
    port = document.getElementById("queue_port").value;
    document.getElementById("connect_messages").innerHTML = 'Connecting to: ' + host + ' on port: ' + port;
    client = new Paho.MQTT.Client(host, Number(port), clientID);
    client.onConnectionLost = onConnectionLost;
    client.onMessageArrived = onMessageArrived;

    client.connect({ 
        onSuccess: onConnect,
        useSSL: false
    });
}

function startDisconnect() {
    client.disconnect();
    document.getElementById("connect_messages").innerHTML = 'Disconnected';
}
