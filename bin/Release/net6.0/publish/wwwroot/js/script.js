window.scrollToBottom = function (id) {
    //let element = document.querySelector('#message-list');
    /*let element = document.querySelector('#message-group');*/

    let element = document.querySelector(`#${id}`)
    element.scrollTop = element.scrollHeight; 
}


function openFileDialog(inputId) {
    document.querySelector(`#${inputId}`).click();
}



//function openFileDialog() {
//    document.querySelector('#f1').click();
//}
