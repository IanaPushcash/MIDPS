function AJAX() {
    try {
        removeChildren(tema);
    }
    catch (e) {console.log(e);}
    try {
        removeChildren(obiective);
    }
    catch (e) {console.log(e);}
    try {
        removeChildren(basic);
    }
    catch (e) {console.log(e);}
    try {
        removeChildren(normal);
    }
    catch (e) {console.log(e);}
    try {
        removeChildren(advanced);
    }
    catch (e) {console.log(e);}
    try {
        removeChildren(bonus);
    }
    catch (e) {console.log(e);}
    try {
        removeChildren(ref);
    }
    catch (e) {console.log(e);}
    $.ajax({
        type: "POST",
        url: "http://localhost/name/fromDB.php",
        data: "value=" + document.getElementById("num").value,
        dataType: "json"
    }).done(function (data) {
        console.log(data[0].tema);
        for (var i = 0; i < data.length; i++) {
            addChild("tema", data[i].tema);
            addChild("obiective", data[i].obiective);
            addChild("basic", data[i].task1);
            addChild("normal", data[i].task2);
            addChild("advanced", data[i].task3);
            addChild("bonus", data[i].bonus_task);
            addChild("ref", data[i].information);
        }

    })

}
function removeChildren(node) {
    var children = node.childNodes;

    while (children && children.length) {
        node.removeChild(children[0])
    }
}

function addChild(node, data){
    var t = document.createElement('p');
    t.innerHTML = data;
    document.getElementById(node).appendChild(t);
}