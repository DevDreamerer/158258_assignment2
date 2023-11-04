document.addEventListener('DOMContentLoaded', function() {
    var act = document.querySelectorAll('.nav ul li');

    for (var i = 0; i < act.length; i++) {
        act[i].addEventListener('click', function() {
            for (var j = 0; j < act.length; j++) {
                act[j].classList.remove('active');
            }
            this.classList.add('active');
        });
    }
});

