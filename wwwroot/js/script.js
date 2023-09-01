window.scrollToBottom = function (id) {
    //let element = document.querySelector('#message-list');
    /*let element = document.querySelector('#message-group');*/

    let element = document.querySelector(`#${id}`)
    element.scrollTop = element.scrollHeight; 
}

// wwwroot/js/screenSize.js
window.getScreenWidth = () => {
    return window.innerWidth || document.documentElement.clientWidth || document.body.clientWidth;
};


function openFileDialog(inputId) {
    document.querySelector(`#${inputId}`).click();
}



//function openFileDialog() {
//    document.querySelector('#f1').click();
//}
