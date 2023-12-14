function successMessage(message, url) {
    //Swal.fire({
    //    title: "Success!",
    //    text: message,
    //    icon: "success",
    //});

    Swal.fire({
        title: "Success!",
        text: message,
        icon: "success",
        showDenyButton: false,
        showCancelButton: false,
        confirmButtonText: "Ok",
    }).then((result) => {
        if (result.isConfirmed && url != undefined) {
            location.href = url;
        }
    });
}
function confirmMessage(message) {
    return new Promise((resolve, reject) => {
        Swal.fire({
            title: "Confirm",
            text: message,
            icon: "warning",
            showCancelButton: true,
        }).then((result) => {
            // return result.isConfirmed;
            resolve(result.isConfirmed)
        });
    });
}


function warningMessage(message) {
    Swal.fire({
        title: "Warning!",
        text: message,
        icon: "warning",
    });
}

function errorMessage(message) {
    Swal.fire({
        title: "Error!",
        text: message,
        icon: "error",
    });
}

function showMessage(data, url) {
    if (data.isSuccess) {
        successMessage(data.message, url);
    }
    else {
        errorMessage(data.message);
    }
}