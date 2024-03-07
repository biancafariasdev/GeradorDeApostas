document.addEventListener("DOMContentLoaded", function() {
    var generateLink = document.querySelector('a[href*="Create"]');
    if (generateLink) {
        generateLink.addEventListener("click", function(event) {
            var confirmCreate = confirm("Deseja gerar uma nova aposta?");
            if (!confirmCreate) {
                event.preventDefault();
            }
        });
    }
});
