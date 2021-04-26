
class Categorias {

    RegistrarCategoria() {
        $.post(
            "GetCategorias",
            $('.formCategorias').serialize(),
            (response) => {
                try {
                var item = JSON.parse(response);
                if (item.Code == "Done") {
                    window.location.href = "Categorias";
                }
                else {
                    document.getElementById("mensaje").innerHTML = item.Description;
                }
                } catch (e) {
                    document.getElementById("mensaje").innerHTML = response;
                }
                
                console.log(response);
            }
        );
    }
}
