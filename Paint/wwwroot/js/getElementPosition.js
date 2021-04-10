function getElementPosition(element) {
    var obj = {};
    obj.x = element.offsetLeft;
    obj.y = element.offsetTop;
    return JSON.stringify(obj);
}