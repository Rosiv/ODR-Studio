namespace :data do

  desc "Shows all data files"
  task :show do
      puts '==================== mp3 files ====================:'
      system 'ls -alh ./data/mp3 | grep ^-'

      puts '==================== wav files ====================:'
      system 'ls -alh ./data/wav | grep ^-'

      puts '=================== dabp files ====================:'
      system 'ls -alh ./data/dabp | grep ^-'

      puts '=================== eti files ====================:'
      system 'ls -alh ./data/eti | grep ^-'
  end

  desc "Removes all wav, dabp and eti files"
  task :clear do
    system `rm -rf ./data/wav/*`
    system `rm -rf ./data/dabp/*`
    system `rm -rf ./data/eti/*`
  end

  desc "Generates files"
  task :generate do
    puts 'Converting mp3 -> wav...'
    Dir.glob("./data/mp3/*.mp3") do | mp3_file |
     puts "Converting #{mp3_file}..."
     basename = File.basename(mp3_file, ".mp3")
     command = "mpg123 -r 48000 -v -w ./data/wav/#{basename}.wav ./data/mp3/#{basename}.mp3"
     puts command
     system `#{command}`
    end
    puts 'Converting wav -> dabp...'
    Dir.glob("./data/wav/*.wav") do | wav_file |
     puts "Converting #{wav_file}..."
     basename = File.basename(wav_file, ".wav")
     command = "dabplus-enc -b 128 -r 48000 -i ./data/wav/#{basename}.wav -o ./data/dabp/#{basename}.dabp"
     puts command
     system `#{command}`
    end

  end

end