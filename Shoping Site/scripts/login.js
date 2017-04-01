

function mostrarCrearCuenta() {
    document.getElementById('pagCrearCuenta').style.display = 'block';
    document.getElementById('contenido').style.display = 'none';
    document.getElementById('contactenos').style.display = 'none';
}

function mostrarContactenos() {
    document.getElementById('contactenos').style.display = 'block';
    document.getElementById('contenido').style.display = 'none';
    document.getElementById('pagCrearCuenta').style.display = 'none';
}

function mostrarContenido() {
    document.getElementById('contenido').style.display = 'block';
    document.getElementById('contactenos').style.display = 'none';
    document.getElementById('pagCrearCuenta').style.display = 'none';
}

function ejemplo(elemento) {
    alert('Gracias por pinchar ' + elemento.id + ' ' + elemento.title);

}