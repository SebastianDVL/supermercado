let addButton = document.querySelector("button")
let btnCerrar = document.querySelector("#btnCerrar")
let panelAdd = document.getElementById("panelAdd")


panelAdd.style.display = "none"
addButton.addEventListener('click', e => {
    e.preventDefault()
    panelAdd.style.display = ""
})

btnCerrar.addEventListener("click", e => {
    e.preventDefault()
    panelAdd.style.display = "none"
})

//document.getelementbyid("btagregar").addeventlistener("click",e => e.preventdefault())