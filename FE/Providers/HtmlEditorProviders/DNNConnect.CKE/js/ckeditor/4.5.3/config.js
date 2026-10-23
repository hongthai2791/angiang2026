CKEDITOR.editorConfig = function (config) {
    config.toolbar_Full = [
        ['Templates', 'Image', 'Flash', 'Templates', 'Link', 'Unlink', 'Templates'],
        ['Bold', 'Italic', 'Underline', 'Strike', 'RemoveFormat', 'Subscript', 'Superscript'],
        ['Font', 'FontSize'],
        ['TextColor', 'BGColor', 'JustifyLeft', 'JustifyCenter', 'JustifyRight', 'JustifyBlock', 'Undo'],
        ['Redo', 'Table', 'NumberedList', 'BulletedList', 'Outdent', 'Indent', 'Print', 'Maximize']
    ];
    config.toolbar_PSA = [
        ['Bold', 'Italic', 'Underline', 'Strike', 'RemoveFormat', 'Subscript', 'Superscript']
    ];
    config.toolbar_Lang = [
        ['Templates', 'Image', 'Flash', 'Button', 'Link', 'Unlink'],
        ['Bold', 'Italic', 'Underline', 'Strike', 'RemoveFormat', 'Subscript', 'Superscript'],
        ['TextColor', 'BGColor', 'JustifyLeft', 'JustifyCenter', 'JustifyRight', 'JustifyBlock', 'Undo'],
        ['Redo', 'Table', 'NumberedList', 'BulletedList', 'Outdent', 'Indent', 'Print', 'Maximize']
    ];
    config.toolbar_Info = [
        ['Image', 'Source', 'Link', 'Unlink', 'Bold', 'Italic', 'Underline', 'Strike', 'RemoveFormat', 'Subscript', 'Superscript']
    ];
    config.toolbar = 'Full';
    config.extraPlugins = 'wordcount';
    config.tabSpaces = 6;
    config.forcePasteAsPlainText = true;
    config.pasteFromWordRemoveStyles = true;
    config.pasteFromWordRemoveFontStyles = true;

};
