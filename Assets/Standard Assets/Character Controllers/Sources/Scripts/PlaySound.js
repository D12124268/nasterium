var sound : AudioClip[] = new AudioClip[5];
 
function Start(){
    InvokeRepeating("PlayClipAndChange",0.01f,5.0f);
}
 
function PlayClipAndChange(){
    audio.clip = sound[Random.Range(0, 4)];
    audio.Play();
}