// Load HTTP module
const http = require("http");
const prompt = require('prompt-sync')({sigint: true});

const hostname = "127.0.0.1";
const port = 8000;

// Create HTTP server
const server = http.createServer(function (req, res) {
  // Set the response HTTP header with HTTP status and Content type
  res.writeHead(200, { "Content-Type": "text/plain" });

  // Send the response body "Hello World"
  res.end("Hello World\n");
});

var lotArray = ["Virginia Ave", "Conley", "10th & Cherry", "Hitt Street", "Turner Ave", "5th & Walnut", "Short Street Garage", "8th & Cherry", "6th & Cherry", "8th & Walnut", "UM Hospital", "William Street Garage", "UM Lot A", "UM Lot AV8", "UM Lot AV11", "UM Lot G", "Lot J"];

const readline = require('readline').createInterface({
    input: process.stdin,
    output: process.stdout
  });

  readline.question('What parking lot have you parked in?', lotname => {
    console.log(`You've parked in ${lotname}!`);
    readline.close();
  });

  const num = prompt('On a scale of 1-10, how full do you think the lot is? ');
  console.log(percentLot(num) * 10);
  console.log('You have stated that ${lotname} is ${num}% full!');


// Prints a log once the server starts listening
server.listen(port, hostname, function () {
  console.log(`Server running at http://${hostname}:${port}/`);
});
