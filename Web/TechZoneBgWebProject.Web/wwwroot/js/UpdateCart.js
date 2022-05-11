var token = $("#reactions-form input[name=__RequestVerificationToken]").val();
var cartSum = document.querySelector("#cartSum");
var totalSum = document.querySelector("#totalSum");
$("tr.tt-itemCart").click(function (e) {
    let quantity = e.target.offsetParent.childNodes[5];
    if (e.target.className == "add-to-cart-left" || e.target.className == "add-to-cart-right") {
        e.preventDefault();
        if (e.target.className == "add-to-cart-left") {
            if (quantity.value > 1) {
                quantity.value = (Number(quantity.value) - 1).toString();
            }
        }
        if (e.target.className == "add-to-cart-right") {
            quantity.value = (Number(quantity.value) + 1).toString();
        }

        if (quantity.value < 1) {
            quantity.value = 1;
        }
        let id = Number(e.currentTarget.id);
        let DTO = { "quantity": quantity.value, "id": id };

        $.ajax({
            type: "POST",
            url: "/api/addCart/update",
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
                let price = Number(e.currentTarget.getAttribute("price"));
                cartSum.textContent = `${string} лв.`
                e.target.offsetParent.childNodes[3].value = 1;
                e.currentTarget.childNodes[9].textContent = `${(quantity.value * price).toFixed(2)} лв.`;
                totalSum.textContent = `${string} лв.`;
                //alert(`поръчахте ${string}`);
            },
            error: function (xmlhttprequest, textstatus, errorthrown) {
                alert(" conection to the server failed ");
                console.log("error: " + errorthrown);
            }
        });
    }
})