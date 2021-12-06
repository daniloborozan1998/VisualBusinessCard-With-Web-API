let usernameInput = document.getElementById("loginUsername1");
let passInput = document.getElementById("loginPassword1");



document.getElementById("loginBtn1").onclick = async () => {
    let user = {
        Username: usernameInput.value,
        Password: passInput.value
    };

    let response = await fetch("http://localhost:56521/api/user/login",
            {
                method: 'POST',
                headers: {

                    'Content-type': 'application/json'
                },
                body: JSON.stringify(user)
            })

        .then(function (response) {
            console.log(response);
            response.text()
                .then(function (text) {
                    localStorage.setItem("userApiToken", text);
                    window.location.href = "http://localhost:56521/templates/editor.html";
                    /*Saving the username from input field to the Local Storage*/
                    if (typeof (Storage) !== "undefined") {
                        // Store
                        top.Username = document.getElementById("loginUsername").value;
                        localStorage.setItem("username", top.Username);
                        // Retrieve
                        document.getElementById("meni").innerHTML = localStorage.getItem("username");
                    } else {
                        document.getElementById("meni").innerHTML = "Sorry, your browser does not support Web Storage...";
                    }



                });

        })
        .catch(function (err) {
            console.log(err);
        });
}