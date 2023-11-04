document.addEventListener("DOMContentLoaded", function () {
    const button = document.getElementById('button');
    const list = document.getElementById('list');
    let isListVisible = false; // 初始时超链接列表是隐藏的

    // 点击按钮时的事件处理
    button.addEventListener('click', () => {
        if (!isListVisible) {
            list.style.display = 'block';
            isListVisible = true;
        } else {
            list.style.display = 'none';
            isListVisible = false;
        }
    });

    // 点击页面其他地方时的事件处理
    document.addEventListener('click', (event) => {
        if (event.target !== button && event.target !== list) {
            list.style.display = 'none';
            isListVisible = false;
        }
    });
});
