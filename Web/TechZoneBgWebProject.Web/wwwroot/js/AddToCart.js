
var token = $("#reactions-form input[name=__RequestVerificationToken]").val();
var cartSum = document.querySelector("#cartSum");
$("a").click(function (e) {
    if (e.target.className == "add-to-cart-quantity" || e.target.className == "add-to-cart-left" || e.target.className == "add-to-cart-span" || e.target.className == "add-to-cart-right") {
        e.preventDefault();
        if (e.target.className == "add-to-cart-left") {
            let quantity = e.target.offsetParent.childNodes[3];
            if (quantity.value > 1) {
                quantity.value = (Number(quantity.value) - 1).toString();
            }
        }
        if (e.target.className == "add-to-cart-right") {
            let quantity = e.target.offsetParent.childNodes[3];
            quantity.value = (Number(quantity.value) + 1).toString();
        }
        if (e.target.className == "add-to-cart-span") {
            let quantity = Number(e.target.offsetParent.childNodes[3].value);
            if (quantity < 1) {
                quantity = 1;
            }
            let id = Number(e.currentTarget.id);
            let DTO = { "quantity": quantity, "id": id };

            $.ajax({
                type: "POST",
                url: "/api/addCart/add",
                data: JSON.stringify(DTO),
                contentType: 'application/json; charset=utf-8',
                datatype: "json",
                headers: { 'X-CSRF-TOKEN': token },
                headers:
                {
                    "RequestVerificationToken": document.getElementById('RequestVerificationToken').value
                },
                success: function (result) {
                    let string = Object.values(result);
                    cartSum.textContent = `${string} лв.`
                    e.target.offsetParent.childNodes[3].value = 1;
                },
                error: function (xmlhttprequest, textstatus, errorthrown) {
                    alert(" conection to the server failed ");
                    console.log("error: " + errorthrown);
                }
            });
        }
    }
    $(document).ready(function () {
        $("#div_Loader").hide();
    });

    function Show() {
        $('#div_Loader').show();
    }

    function Hide() {
        $('#div_Loader').hide();
    }
})