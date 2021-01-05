window.ShowToastr = (type, message) => {
    if (type === "success") {
        toastr.success(message, 'Operation successful');
    }
    if (type === 'error') {
        toastr.error(message, 'Operation failed!')
    }
}

window.ShowSwal = (type, message) => {
    if (type === 'success') {
        Swal.fire(
            'Success!',
            message,
            'success'
        );
    }
    if (type === 'error') {
        Swal.fire(
            'Error!',
            message,
            'error'
        );
    }
}