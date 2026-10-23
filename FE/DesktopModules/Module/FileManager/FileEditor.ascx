<%@ Control Language="vb" CodeFile="FileEditor.ascx.vb" Inherits="Modules.FileManager.Editor" AutoEventWireup="false" Explicit="True" %>
<div class="modal fade modal-fileManager" id="modalFileManager" role="dialog" aria-labelledby="myLargeModalLabel">
    <div class="modal-dialog  modal-md" style="width: 1024px">
        <div class="modal-content">
            <div class="modal-header" style="background-color: #4286F5;">
                <button type="button" class="close" data-dismiss="modal" onclick="closeModal();return false;" aria-label="Close" style="color: white; opacity: 1; margin-top: -1px !important;">
                    <span aria-hidden="true">&times;</span></button>
                <h4 class="modal-title">QUẢN LÝ TỆP ĐÍNH KÈM
                </h4>
            </div>
            <iframe class="pif pif-fileManager" url="" src="" style="width: 100%; min-height: 450px"

                scrolling="no" frameborder="0"></iframe>
        </div>
    </div>
</div>