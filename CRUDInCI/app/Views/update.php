<div class="container">
    <h1 class="text-center">Form Create</h1>
<form method="POST" action="<?= base_url('home/update/'.$item->id) ?>">
  <div class="mb-3">
    <label for="exampleInputEmail1" class="form-label">Nama</label>
    <input type="text" class="form-control" id="exampleInputEmail1" aria-describedby="emailHelp" placeholder="Nama" name="nama" value="<?= $item->nama ?>">
  </div>
  <div class="mb-3">
    <label for="exampleInputPassword1" class="form-label">No Handphone</label>
    <input type="text" class="form-control" id="exampleInputPassword1" placeholder="No Handphone" name="nohp" value="<?= $item->nohp ?>">
  </div>
  <div class="mb-3">
    <label for="exampleInputPassword1" class="form-label">Tanggal Lahir</label>
    <input type="date" class="form-control" id="exampleInputPassword1" placeholder="Tanggal Lahir" name="tgllahir" value="<?= $item->tgllahir ?>">
  </div>
  <div class="mb-3">
    <label for="exampleInputPassword1" class="form-label">Golongan</label>
    <input type="text" class="form-control" id="exampleInputPassword1" placeholder="Golongan" name="golongan" value="<?= $item->golongan ?>">
  </div>
  <div class="d-grid gap-2">
  <button type="submit" class="btn btn-primary">Submit</button>
  </div>
</form>
</div>