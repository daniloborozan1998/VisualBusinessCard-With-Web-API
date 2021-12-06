document.getElementById('logOut').onclick = () => {
    localStorage.clear();
    window.location.href = "http://localhost:56521/templates/index.html";
}