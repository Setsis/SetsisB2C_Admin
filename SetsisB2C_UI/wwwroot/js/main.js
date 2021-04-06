




        //document.getElementById("product").addEventListener("click", function () {

            //    var search = document.getElementById("crd");
            //    var table = document.getElementById("tableproduct");

            //    if (search.style.display == "none") {

            //        search.style.display = "block";

            //    }
            //});

console.log("merhaba");


$('#search').change(function () {
    var selection = $('#search').val();
    if (selection.length > 0) {
        $.ajax({
            type: "POST",
            url: '@Url.Action("PostItemCode", "ShowCase")',
            data: {
                ItemCode: selection
            },
            success: function (data) {
                alert("merhaba")
            },
            error: function () {
                alert('error');
            }

        });
    }
})
   

    //  $(document).ready(function () {

    //    $("#search").keyup(I => {
    //        let item = $("#search").val();
    //        $.ajax({


    //            dataType: "text",
    //            type: "Post",
    //            url: "http://10.20.8.6:2023/Stock/GetItemDesc?ItemCode=" + item,
    //            data: JSON.stringify({ItemCode: item }),
    //            success: function (data) {

    //                console.log(data);
    //            }
    //        });
    //    })
    //});