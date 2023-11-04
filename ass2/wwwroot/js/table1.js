// 获取超链接元素
const link = document.getElementById('myLink');

// 创建一个变量来跟踪样式状态
let isHovered = false;

// 定义超链接的hover样式
const hoverStyle = {
    color: 'rgb(87, 70, 39)',
    fontSize: '35px'
};

// 定义普通样式
const normalStyle = {
    color: 'black',
    fontSize: 'inherit'
};

// 鼠标进入时应用:hover样式
link.addEventListener('mouseenter', function () {
    link.style.color = hoverStyle.color;
    link.style.fontSize = hoverStyle.fontSize;
    isHovered = true;
});

// 鼠标移开时应用普通样式
link.addEventListener('mouseleave', function () {
    link.style.color = normalStyle.color;
    link.style.fontSize = normalStyle.fontSize;
    isHovered = false;
});

// 设置定时器，每隔2秒切换样式
setInterval(function () {
    if (!isHovered) {
        // 如果当前不是:hover状态，切换样式
        if (link.style.color === normalStyle.color) {
            link.style.color = hoverStyle.color;
            link.style.fontSize = hoverStyle.fontSize;
        } else {
            link.style.color = normalStyle.color;
            link.style.fontSize = normalStyle.fontSize;
        }
    }
}, 1000);