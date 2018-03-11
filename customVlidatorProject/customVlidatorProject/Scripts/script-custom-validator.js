
var startDate = document.getElementById("StartDate");
var endDate = document.getElementById("EndDate");

var DispMsg = document.getElementById("DispMsg");
var DispMsg1 = document.getElementById("DispMsg1");

startDate.addEventListener("change", myFocus);

function myFocus() {
    console.log(Date.now() + " <> " + (new Date(startDate.value)).getTime());
    if (Date.now() > (new Date(startDate.value)).getTime()) {
        DispMsg.innerHTML = "Joining date Cannot be Greater than Current Date";
        return false;
    }
    else {
        DispMsg.innerHTML = "";
    }
}

endDate.addEventListener("change", myFocus1);

function myFocus1() {
    if ((new Date(endDate.value)).getTime() < (new Date(startDate.value)).getTime()) {
        DispMsg1.innerHTML = "End date Cannot be Greater than Current Date";
        return false;
    }
    else {
        DispMsg1.innerHTML = "";
    }
}