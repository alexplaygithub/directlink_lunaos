function checkPassword() {
    var password = document.getElementById("password-input").value;

    // Replace "your-password" with the actual password
    if (password === "your-password") {
        window.location.href = "https://example.com";
    } else {
        alert("Incorrect password! Please try again.");
    }
}
