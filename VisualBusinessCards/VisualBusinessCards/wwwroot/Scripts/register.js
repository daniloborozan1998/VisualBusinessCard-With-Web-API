let regBtn = document.getElementById("regBtn");
let fn = document.getElementById("firstName");
let ln = document.getElementById("lastName");
let username = document.getElementById("registerUsername");
let pass = document.getElementById("registerPassword");
let confPass = document.getElementById("confPass");



let registerBtn = async (e) => {
    e.preventDefault();
    let url = "http://localhost:56521/api/user/register";
    let user = {
        FirstName: fn.value,
        LastName: ln.value,
        Username: username.value,
        Password: pass.value,
        ConfirmedPassword: confPass.value
    };

    let response = await fetch(url, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(user)
        })
        .then(function(response) {
            console.log(response);
            window.location.href = "http://localhost:56521/templates/login.html";
        })
        .catch(function(error) {
            console.log(error);
        });
}
regBtn.addEventListener("click", registerBtn);