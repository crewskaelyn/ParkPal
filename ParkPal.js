var lotArray = ["Virginia Ave", "Conley", "10th & Cherry", "Hitt Street", "Turner Ave", "5th & Walnut", "Short Street Garage", "8th & Cherry", "6th & Cherry", "8th & Walnut", "UM Hospital", "William Street Garage", "UM Lot A", "UM Lot AV8", "UM Lot AV11", "UM Lot G", "Lot J"];

const readline = require('readline').createInterface({
  input: process.stdin,
  output: process.stdout
});

for(let i = 0; i < lotArray.length; i++){
  console.log(lotArray[i]);
}


if((lotArray.includes(lotname)) == false){
  readline.question('What parking lot have you parked in? Select from the above list :'), lotname => {

    console.log(`You've parked in ${lotname}!`);

  
  
}


readline.question('How full is this parking lot on a scale of 1 through 10?', lotpercent => {
  console.log(lotpercent(Number) * 10);
  readline.close();
  });
  
};
