document.getElementById("buttoncalc").addEventListener("click", function () {


    var grade = (document.getElementById("assignments").value * 0.55) + (document.getElementById("gproject").value * 0.05) +
        (document.getElementById("quiz").value * 0.1) + (document.getElementById("exam").value * 0.2) + (document.getElementById("intex").value * 0.1)
    var lettergrade = ''
    //if (grade > 93) {
     //   lettergrade = 'A'



    alert("Final Grade: " + grade + '%')
    
})