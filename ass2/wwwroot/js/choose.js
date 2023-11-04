var btns = document.querySelectorAll('.choose ul li')
var tabs = document.querySelectorAll('.choose ol li')
var bg = document.querySelector('.choose ol')

for (var i = 0; i < btns.length; i++) {
    btns[i].onclick = (function(index) {
        return function() {
            for (var j = 0; j < btns.length; j++) {
                btns[j].className = '';
                tabs[j].className = '';
            }
            
            btns[index].className = 'active';
            tabs[index].className = 'active';


            if (index === 0) {
                bg.style.backgroundImage = "url('/wwwroot/img/b1.jpg')";
            } else if (index === 1) {
                bg.style.backgroundImage = "url('/wwwroot/img/b2.jpg')";
            } else if(index === 2){
                bg.style.backgroundImage = "url('/wwwroot/img/b3.jpg')";
            }else if(index === 3){
                bg.style.backgroundImage = "url('/wwwroot/img/b4.jpg')";
            }else if(index === 4){
                bg.style.backgroundImage = "url('/wwwroot/img/b5.jpg')";
            }else if(index === 5){
                bg.style.backgroundImage = "url('/wwwroot/img/b6.jpg')";
            }else if(index === 6){
                bg.style.backgroundImage = "url('/wwwroot/img/b7.jpg')";
            }else if(index === 7){
                bg.style.backgroundImage = "url('/wwwroot/img/b8.jpg')";
            }else if(index === 8){
                bg.style.backgroundImage = "url('/wwwroot/img/b9.jpg')";
            }else if(index === 9){
                bg.style.backgroundImage = "url('/wwwroot/img/b10.jpg')";
            }else if(index === 10){
                bg.style.backgroundImage = "url('/wwwroot/img/b11.jpg')";
            }else if(index === 11){
                bg.style.backgroundImage = "url('/wwwroot/img/b12.jpg')";
            }

        };
    })(i);
}
