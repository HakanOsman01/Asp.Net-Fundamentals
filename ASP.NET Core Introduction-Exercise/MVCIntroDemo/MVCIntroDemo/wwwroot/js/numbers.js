function SetLimtedNumbers() {
    let num = document.getElementById("GetLimitInputId").value || 50;
    window.location = "https://localhost:7188/Numbers/NumbersToN/?count="+num;

}