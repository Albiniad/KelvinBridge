checkVValue();

function selectVariant() {
    var selectElement = document.getElementById("variantSelect");
    var selectedIndex = selectElement.selectedIndex;
    var selectedOption = selectElement.options[selectedIndex];
    var Ra = selectedOption.getAttribute("data-ra");
    var Rm = selectedOption.getAttribute("data-rm");
    var Rn = selectedOption.getAttribute("data-rn");
    var RM = selectedOption.getAttribute("data-rmm");
    var RN = selectedOption.getAttribute("data-rnn");

    document.getElementById("Ra").value = Ra;
    document.getElementById("Rm").value = Rm;
    document.getElementById("Rn").value = Rn;
    document.getElementById("RM").value = RM;
    document.getElementById("RN").value = RN;
    calculateV(RM, RN, Rm, Rn);
    checkVValue();
}

function calculateV(RM, RN, Rm, Rn) {
    $.ajax({
        url: '/Home/CalculateVoltage',
        type: 'POST',
        data: { RMM: RM, RNN: RN, Rm: Rm, Rn: Rn },
        success: function (response) {
            document.getElementById("V").value = parseFloat(response).toFixed(3);
        },
        error: function (error) {
            console.log(error);
        }
    });
}

function fieldsChange() {
    var Rm = document.getElementById("Rm").value;
    var Rn = document.getElementById("Rn").value;
    var RM = document.getElementById("RM").value;
    var RN = document.getElementById("RN").value;

    calculateV(RM, RN, Rm, Rn);
    checkVValue();
}

function calculateResult() {
    var Ra = parseFloat(document.getElementById("Ra").value);
    var RM = parseFloat(document.getElementById("RM").value);
    var RN = parseFloat(document.getElementById("RN").value);

    if (isNaN(Ra) || isNaN(RM) || isNaN(RN)) {
        $('#myModal').modal('show');
    } else {
        $.ajax({
            url: '/Home/CalculateResult',
            type: 'POST',
            data: { Ra: Ra, RM: RM, RN: RN },
            success: function (response) {
                document.getElementById("Rx").value = parseFloat(response).toFixed(3);
            },
            error: function (error) {
                console.log(error);
            }
        });
    }
}

function resetFields() {
    document.getElementById("variantSelect").selectedIndex = 0;
    document.getElementById("Ra").value = "";
    document.getElementById("Rm").value = "";
    document.getElementById("Rn").value = "";
    document.getElementById("RM").value = "";
    document.getElementById("RN").value = "";
    document.getElementById("V").value = "";
    document.getElementById("Rx").value = "";
    checkVValue();
}

function closeModal() {
    $('#myModal').modal('hide');
}

function checkVValue() {
    setTimeout(function () {
        var vInput = document.getElementById("V");
        var calculateButton = document.getElementById("buttonResult");

        if (vInput.value === '' || isNaN(parseFloat(vInput.value)) || parseFloat(vInput.value) <= 0) {
            calculateButton.disabled = true;
        } else {
            if (parseFloat(vInput.value) <= 0.005) {
                calculateButton.disabled = false;
            } else {
                calculateButton.disabled = true;
            }
        }
    }, 100);
}