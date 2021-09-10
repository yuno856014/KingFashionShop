var category = {};
category.showData = function (id) {
    $.ajax({
        url: `https://localhost:44368/CategoryDetails/${Id}`,
        method: "GET",
        success: function (data) {
            $('#tbCategory tbody').empty();
            $.each(data, function (index, item) {
                $('#tbCategory tbody').append(`
                    <tr>
                        <td>
                            ${item.catDetailsId}
                        </td>
                        <td>
                            ${item.catDetailsName}
                        </td>
                        <td>
                            <span class="btn btn-sm ${item.status ? 'btn-warning' : 'btn-danger'}">${item.status ? 'Sẵn Có' : 'Hết Hàng'}</span>
                        </td>
                        <td>
                            <a href='javascript:;' class="btn btn-icon" title="Phục Hồi" onclick='category.restore(${item.catDetailsId})'><span class="btn btn-sm ${item.isDeleted ? 'btn-warning' : 'btn-danger'}">${item.isDeleted ? 'Đã Xóa' : 'Chưa Xóa'}</span></a>
                        </td>
                        <td>
                            <a href='javascript:;' class="btn btn-icon" title="Sửa" onclick="category.get(${item.catDetailsId})"><i class="ti-pencil"></i></a>
                            <a href='javascript:;' class="btn btn-icon" title="Xóa" onclick='category.remove(${item.catDetailsId})'><i class="ti-trash"></i></a>
                            <a href='javascript:;' class='btn btn-icon ${item.status ? 'btn-warning' : 'btn-success'}'
                                   title='${item.status ? 'Sẵn Có' : 'Hết Hàng'}' onclick='category.changeStatus(${item.catDetailsId}, ${item.status})'>
                                    <i class='${item.status ? 'ti-lock' : 'ti-unlock'}'></i>
                             </a>
                        </td>
                    </tr>
                `);
            });
            $('#tbCategory').DataTable({
                columnDefs: [
                    { orderable: false, targets: 3 },
                    { "searchable": false, "targets": 2 }
                ],
                order: [[0, 'desc']]
            });
            $('#tbCategory_wrapper').addClass('w-100');
        }
    });
};
category.openModel = function () {
    category.reset();
    $('#categoryModel').modal('show');
}
category.save = function () {
    if ($('#frmCategory').valid()) {
        let catDetailsId = parseInt($('input[name="CatDetailsId"]').val());
        //create new category
        if (catDetailsId == 0) {
            var createCategoryObj = {};
            createCategoryObj.CatDetailsName = $('input[name="CatDetailsName"]').val();
            createCategoryObj.Status = $('input[name="Status"]').is(":checked");
            createCategoryObj.categoryName = $('input[name="CategoryName"]').val();
            $.ajax({
                url: "https://localhost:44368/CategoryDetails/Create",
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
            updateCategoryObj.catDetailsId = catDetailsId;
            updateCategoryObj.catDetailsName = $('input[name="CatDetailsName"]').val();
            updateCategoryObj.Status = $('input[name="Status"]').is(":checked");
            createCategoryObj.categoryName = $('input[name="CategoryName"]').val();
            $.ajax({
                url: "https://localhost:44368/CategoryDetails/Update",
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
    $('input[name="CatDetailsId"]').val(0);
}
category.changeStatus = function (id, status) {
    bootbox.confirm({
        title: `${status ? "Inactive" : "Active"} category?`,
        message: `Do you want to ${status ? "inactive" : "active"} the category now?`,
        buttons: {
            cancel: {
                label: '<i class="fa fa-times"></i> Cancel'
            },
            confirm: {
                label: '<i class="fa fa-check"></i> Confirm'
            }
        },
        callback: function (result) {
            if (result) {
                var changeStatusCategoryObj = {};
                changeStatusCategoryObj.CatDetailsId = id;
                changeStatusCategoryObj.Status = status;
                $.ajax({
                    url: "https://localhost:44368/CategoryDetails/ChangeStatus",
                    method: "PUT",
                    dataType: "json",
                    contentType: "application/json",
                    data: JSON.stringify(changeStatusCategoryObj),
                    success: function (data) {
                        if (data.success) {
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
    });
}
category.remove = function (id) {
    bootbox.confirm({
        title: `Remove category?`,
        message: `Do you want to remove the category now?`,
        buttons: {
            cancel: {
                label: '<i class="fa fa-times"></i> Cancel'
            },
            confirm: {
                label: '<i class="fa fa-check"></i> Confirm'
            }
        },
        callback: function (result) {
            if (result) {
                $.ajax({
                    url: `https://localhost:44368/CategoryDetails/Remove/${id}`,
                    method: "DELETE",
                    success: function (data) {
                        if (data.success) {
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
    });
}
category.restore = function (id) {
    bootbox.confirm({
        title: `Restore category?`,
        message: `Do you want to restore the category now?`,
        buttons: {
            cancel: {
                label: '<i class="fa fa-times"></i> Cancel'
            },
            confirm: {
                label: '<i class="fa fa-check"></i> Confirm'
            }
        },
        callback: function (result) {
            if (result) {
                $.ajax({
                    url: `https://localhost:44368/CategoryDetails/Restore/${id}`,
                    method: "PATCH",
                    success: function (data) {
                        if (data.success) {
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
    });
}
category.get= function (id) {
    $.ajax({
        url: `https://localhost:44368/CategoryDetails/Get/${catId}`,
        method: "GET",
        success: function (data) {
            $('#categoryModel').modal('show');
            $('input[name="CatDetailsName"]').val(data.catDetailsName);
            $('input[name="CatDetailsId"]').val(data.catDetailsId);
            $('input[name="Status"]').prop('checked', data.status);
        }
    });
}
$(document).ready(function () {
    category.showData(2);
});