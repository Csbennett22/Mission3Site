// java to calculate the grade and output it to an alert box

$("#buttoncalc").click(function () {
    var grade = ($("#assignments").val() * 0.55) + ($("#gproject").val() * 0.05) +
       ($("#quiz").val() * 0.1) + ($("#exam").val() * 0.2) + ($("#intex").val() * 0.1);
    //var lettergrade = ''
    //if (grade > 93) {
    //   lettergrade = 'A'
    alert("Final Grade: " + grade + '%');

})