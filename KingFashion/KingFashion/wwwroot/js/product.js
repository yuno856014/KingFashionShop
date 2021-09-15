var product = {};
$.fn.dataTable.ext.errMode = 'none';
$('#tbProduct').DataTable({
    columnDefs: [
        { orderable: false, targets:11 }
    ],
    order: [[0, 'desc']]
});
product.changeStatus = function (id, status) {
    bootbox.confirm({
        title: `Danh Mục ${status ? "Sẵn Có" : "Hết Hàng"}`,
        message: `Bạn có muốn danh mục đã ${status ? "hết hàng" : "sẵn có"}?`,
        buttons: {
            cancel: {
                label: '<i class="ti-close"></i> Trở Về'
            },
            confirm: {
                label: '<i class="ti-check"></i> Đồng ý'
            }
        },
        callback: function (result) {
            if (result) {
                var changeStatusCategoryObj = {};
                changeStatusCategoryObj.ProductId = id;
                changeStatusCategoryObj.Status = status;
                $.ajax({
                    url: "https://localhost:44368/Product/ChangeStatus",
                    method: "PUT",
                    dataType: "json",
                    contentType: "application/json",
                    data: JSON.stringify(changeStatusCategoryObj),
                    success: function (data) {
                        if (data.success) {
                            location.reload();
                            $.notify(data.message, "success");
                        }
                        else {
                            $.notify(data.message, "error");
                        }
                    }
                });
            }
        }
    });
}
product.openModel = function () {
    product.reset();
    $('#productModel').modal('show');
    $("#exampleModalLabel").html("Thêm Mới Sản Phẩm");
}
product.reset = function () {
    //reset error messages
    $('#frmProduct').validate().resetForm();
    //reset input values
    $('#frmProduct')[0].reset();
    //reset input color
    var inputs = $('#frmProduct input');
    for (let i = 0; i < inputs.length; i++) {
        inputs[i].classList.remove('error');
    }
    //Reset category Id = 0
    $('input[name="ProductId"]').val(0);
}
product.changeIsDeleted = function (id, isDeleted) {
    bootbox.confirm({
        title: `Danh Mục ${isDeleted ? "Đã Xóa" : "Hoạt Động"}`,
        message: `Bạn có muốn ${isDeleted ? "hoạt động" : "xóa"} ngay bây giời không?`,
        buttons: {
            cancel: {
                label: '<i class="ti-close"></i> Trở Về'
            },
            confirm: {
                label: '<i class="ti-check"></i> Đồng ý'
            }
        },
        callback: function (result) {
            if (result) {
                var changeStatusCategoryObj = {};
                changeStatusCategoryObj.ProductId = id;
                changeStatusCategoryObj.IsDeleted = isDeleted;
                $.ajax({
                    url: "https://localhost:44368/Product/ChangeIsDeleted",
                    method: "PUT",
                    dataType: "json",
                    contentType: "application/json",
                    data: JSON.stringify(changeStatusCategoryObj),
                    success: function (data) {
                        if (data.success) {
                            location.reload();
                            $.notify(data.message, "success");
                        }
                        else {
                            $.notify(data.message, "error");
                        }
                    }
                });
            }
        }
    });
}
product.save = function () {
    if ($('#frmProduct').valid()) {
        let catDetailsId = parseInt($('input[name="CatDetailsId"]').val());
        let productId = parseInt($('input[name="ProductId"]').val());
        //create new category
        if (productId == 0) {
            var createProductObj = {};
            createProductObj.ProductName = $('input[name="ProductName"]').val();
            createProductObj.Status = $('input[name="Status"]').is(":checked");
            createProductObj.Color = $('input[name="Color"]').val();
            createProductObj.Price = $('input[name="Price"]').val();
            createProductObj.Photo = $('input[name="Photo"]').val();
            createProductObj.Quantity = $('input[name="Quantity"]').val();
            createProductObj.ProductCode = $('input[name="ProductCode"]').val();
            createProductObj.Description = $('input[name="Description"]').val();
            createProductObj.Size = $('input[name="Size"]').val();
            createProductObj.CatDetailsId = parseInt($('input[name="CatDetailsId"]').val());
            $.ajax({
                url: `https://localhost:44368/Product/${catDetailsId}/Create`,
                method: "POST",
                dataType: "json",
                contentType: "application/json",
                data: JSON.stringify(createProductObj),
                success: function (data) {
                    if (data.success) {
                        $('#productModel').modal('hide');
                        /*$.notify(data.message, "success");*/
                        location.reload();
                    }
                    else {
                        $.notify(data.message, "error");
                    }
                }
            });
        }
        //update category
        else {
            var updateProductObj = {};
            updateProductObj.ProductId = ProductId;
            updateProductObj.ProductName = $('input[name="ProductName"]').val();
            updateProductObj.Status = $('input[name="Status"]').is(":checked");
            updateProductObj.Color = $('input[name="Color"]').val();
            updateProductObj.Price = $('input[name="Price"]').val();
            updateProductObj.Photo = $('input[name="Photo"]').val();
            updateProductObj.Quantity = $('input[name="Quantity"]').val();
            updateProductObj.ProductCode = $('input[name="ProductCode"]').val();
            updateProductObj.Description = $('input[name="Description"]').val();
            updateProductObj.Size = $('input[name="Size"]').val();
            $.ajax({
                url: "https://localhost:44368/CategoryDetails/Update",
                method: "PUT",
                dataType: "json",
                contentType: "application/json",
                data: JSON.stringify(updateProductObj),
                success: function (data) {
                    if (data.success) {
                        $('#productModel').modal('hide');
                        /*$.notify(data.message, "success");*/
                        location.reload();
                    }
                    else {
                        $.notify(data.message, "error");
                    }
                }
            });
        }
    }
}
product.get = function (id) {
    $.ajax({
        url: `https://localhost:44368/Product/Get/${id}`,
        method: "GET",
        success: function (data) {
            $('#productModel').modal('show');
            $('input[name="ProductName"]').val(data.productName);
            $('input[name="ProductId"]').val(data.productId);
            $('input[name="Status"]').prop('checked', data.status);
        }
    });
    $("#exampleModalLabel").html("Sửa Sản Phẩm");
}
$(document).ready(function () {
    $('#tbProduct').DataTable();
});