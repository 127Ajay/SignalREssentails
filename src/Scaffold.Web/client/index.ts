//Import signalr package
const signalR = require("@microsoft/signalr");

//Create connection
let connection = new signalR.HubConnectionBuilder()
.withUrl("/hubs/view")
.build();

//on view update message form client
connection.on("viewCountUpdate", (value: number) => {
    var counter = document.getElementById("viewcounter");
    console.log(value)
    counter.innerText = value.toString();
})


//notify server we are watchin
function notify(){
    connection.send("notifyWatching");
}

//start connection
function startSuccess (){
    console.log("connection successful.")
    notify();
}

function startFail (){
    console.log("connection failed.")
}


connection.start()
.then(startSuccess, startFail)