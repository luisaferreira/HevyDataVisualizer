$(document).ready(function () {
    $("#formWorkout").on("submit", function (e) {
        e.preventDefault();

        let formData = new FormData(this);
        formData.append("file", $("#fileWorkout")[0].files[0]);

        $.ajax({
            type: "POST",
            url: "/Home/ImportFile",
            data: formData,
            processData: false,
            contentType: false,
            cache: false,
            success: function (data) {
                $("#divResults").html(data);
            },
            error: function (err) {
                let mensagem = err.responseJSON;
                console.log(mensagem);
            },
        })
    })
})