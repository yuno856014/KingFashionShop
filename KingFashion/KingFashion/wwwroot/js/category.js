var category = {};
category.showData = function () {
    $.ajax({
        url: "https://localhost:44368/Category/Get",
        method: "GET",
        success: function (data) {
            $('#tbCategory tbody').empty();
            $.each(data, function (index, item) {
                $('#tbCategory tbody').append(
                    `
                        <tr>
                            <td>${item.categoryId}</td>
                            <td>${item.categoryName}</td>
                            <td class='text-right'>
                                 <a href='javascript:;' class="btn btn-mat btn-success btn-square btn-sm" onclick="category.openModel()">
                                    Thêm Mới
                                    <i class="ti-plus"></i>
                                </a>
                                <a href="/CategoryDetails/${item.categoryId}" class='btn btn-info btn-mat btn-sm' title="Xem Danh Mục">Xem Danh Mục
                                    <i class="ti-eye"></i>
                                </a>
                                <a href='javascript:;' class='btn btn-sm btn-secondary' title="Modify category" onclick="category.get(${item.categoryId})">
                                   Sửa <i class="ti-reload"></i>
                                </a>
                            </td>
                        </tr>
                    `
                );
            });
            $.fn.dataTable.ext.errMode = 'none';
            $('#tbCategory').DataTable({
                columnDefs: [
                    { orderable: false, targets: 2 }
                ],
                order: [[0, 'desc']]
            });
            $('#tbCategory_wrapper').addClass('w-100');
        }
    });
}
category.openModel = function () {
    category.reset();
    $('#categoryModel').modal('show');
    $("#exampleModalLabel").html("Thêm mới Danh Mục");
}
category.save = function () {
    if ($('#frmCategory').valid()) {
        let categoryId = parseInt($('input[name="CategoryId"]').val());
        //create new category
        if (categoryId == 0) {
            var createCategoryObj = {};
            createCategoryObj.CategoryName = $('input[name="CategoryName"]').val();
            createCategoryObj.Status = $('input[name="Status"]').is(":checked");
            $.ajax({
                url: "https://localhost:44368/Category/Create",
                method: "POST",
                dataType: "json",
                contentType: "application/json",
                data: JSON.stringify(createCategoryObj),
                success: function (data) {
                    if (data.success) {
                        $('#categoryModel').modal('hide');
                        category.showData();
                        $.notify(data.message, "success");
                    }
                    else {
                        $.notify(data.message, "error");
                    }
                }
            });
        }
        //update category
        else {
            var updateCategoryObj = {};
            updateCategoryObj.CategoryId = categoryId;
            updateCategoryObj.CategoryName = $('input[name="CategoryName"]').val();
            updateCategoryObj.Status = $('input[name="Status"]').is(":checked");
            $.ajax({
                url: "https://localhost:44368/Category/Update",
                method: "PUT",
                dataType: "json",
                contentType: "application/json",
                data: JSON.stringify(updateCategoryObj),
                success: function (data) {
                    if (data.success) {
                        $('#categoryModel').modal('hide');
                        category.showData();
                        $.notify(data.message, "success");
                    }
                    else {
                        $.notify(data.message, "error");
                    }
                }
            });
        }
    }
}
category.reset = function () {
    //reset error messages
    $('#frmCategory').validate().resetForm();
    //reset input values
    $('#frmCategory')[0].reset();
    //reset input color
    var inputs = $('#frmCategory input');
    for (let i = 0; i < inputs.length; i++) {
        inputs[i].classList.remove('error');
    }
    //Reset category Id = 0
    $('input[name="CategoryId"]').val(0);
}
category.get = function (id) {
    $("#exampleModalLabel").html("Sửa Danh Mục");
    $.ajax({
        url: `https://localhost:44368/Category/Get/${id}`,
        method: "GET",
        success: function (data) {
            $('#categoryModel').modal('show');
            $('input[name="CategoryName"]').val(data.categoryName);
            $('input[name="CategoryId"]').val(data.categoryId);
        }
    });
    
}
$(document).ready(function () {
    category.showData();
});

