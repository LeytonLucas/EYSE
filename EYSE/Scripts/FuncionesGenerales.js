
//MostrarAlerta("succes","Prueba");

//function MostrarAlerta(tipo, mensaje) {
//    const fragment = document.createDocumentFragment();
//    const alerta = document.getElementById("template").nodeValue();
//    fragment.appendChild(alerta);

//    document.getElementById("contenedor").appendChild(fragment);
//}

function alertCreate(msg, type) {
    let div = document.getElementById("AlertContenedor")
    div.innerHTML = [
        `<div class="alert alert-${type} alert-dismissible" role="alert">`,
        `   <div>${msg}</div>`,
        '   <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>',
        '</div>'
    ].join('')
}

function AlertaInterna(msg, type, div) {
    let contenedor = document.getElementById(div);
    contenedor.innerHTML = [
        `<div class="alert alert-${type} alert-dismissible" role="alert">`,
        `   <div>${msg}</div>`,
        '   <button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button>',
        '</div>'
    ].join('')
}