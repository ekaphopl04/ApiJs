let onclick = () => {
    console.log("click ...");
    var Height = document.getElementById("HeightTextBox").value;
    var Weight = document.getElementById("WeightTextBox").value;

    axios.post("http://localhost:5000/api/BmiJs/GetBmi2", { Weight: Weight, Height: Height })
    //{ Weight : Weight, Height: Height   }
        .then((response) => {
            console.log(response.data)
        })
        .catch((error) => {
            console.log(error)
        })
}

var button = document.getElementById("Caculate");
button.addEventListener("click", onclick);