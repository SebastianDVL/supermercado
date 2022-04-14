let panelIngresar = document.getElementById('panelIngresar')
let panelBorrar = document.getElementById('panelBorrar')
let panelModificar = document.getElementById('panelModificar')

panelIngresar.style.display = "none";
panelBorrar.style.display = "none";
panelModificar.style.display = "none";

let btnAgregar = document.querySelector(".add")

btnAgregar.addEventListener('click', e => {
    e.preventDefault();
    panelIngresar.style.display = "";
})


let panelProductos = document.querySelectorAll('#panelProductos div .d-flex')

panelProductos.forEach(panel => {
    panel.innerHTML = "<i class='fa-solid fa-pen text-primary my-auto'></i><i class='fa-solid fa-trash text-danger ms-5 my-auto' runat='server' id='borrar'></i>"
    panel.lastChild.addEventListener('click', () => {
        panelBorrar.style.display = "";
        document.querySelector('#codBorrable').value = panel.parentNode.children[1].textContent;
        document.querySelector('#txtConfirmarCodigo').focus();
    })
    panel.firstChild.addEventListener('click', () => {
        panelModificar.style.display = '';
        document.querySelector('#txtModCod').value = panel.parentNode.children[1].textContent;
        document.querySelector('#txtModNom').value = panel.parentNode.children[2].textContent;
        document.querySelector('#txtModMarca').value = panel.parentNode.children[3].textContent;
        document.querySelector('#txtModPrecio').value = panel.parentNode.children[4].textContent.slice(1);
        document.querySelector('#txtModExist').value = panel.parentNode.children[5].textContent;
        document.querySelector('#txtModDesc').focus();
    })
})

