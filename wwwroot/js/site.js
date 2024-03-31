// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


document.getElementById("idEliminarBtn").addEventListener("click", () =>{
    Swal.fire({
        title: "Se ha elimnidado!",
        text: "El libro se ha eliminado correctamente!",
        icon: "success"
      });
})

document.getElementById("idEditarBtn").addEventListener("click", () =>{
    Swal.fire({
        title: "Se ha editado!",
        text: "El libro se ha editado correctamente!",
        icon: "success"
      });
})

document.getElementById("idGuardarBtn").addEventListener("click", () =>{
    Swal.fire({
        title: "Se ha Guardado!",
        text: "El libro se ha Guardado correctamente!",
        icon: "success"
      });
})

